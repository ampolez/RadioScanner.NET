import sqlite3
from urllib2 import urlopen
from bs4 import BeautifulSoup

conn = sqlite3.connect('radioscanner.db')
conn.execute('''CREATE TABLE IF NOT EXISTS freq
             (tx_frequency text,
              rx_frequency text,
              location text,
              date text,
              modulation text,
              signal text,
              radio_service text,
              owner text,
              call text,
              description longtext,
              confirmations int
              )''')


for page in range(0, 769):
    request = BeautifulSoup(urlopen('http://www.radioscanner.ru/base/index.php?page={}'.format(page)))
    freq_table = request.find_all(attrs={"class": "caption1"})
    counter = 1;
    tx_frequency = rx_frequency = location = date = modulation = signal = service = owner = call = description = confirmations = ""        
    for tableEntry in freq_table:
        entry = tableEntry.text
        if counter == 1:
            frequency = entry
            more = BeautifulSoup(urlopen(tableEntry.find("a").get("href")))
            cells = more.find(attrs={"bordercolor": "#999999"}).find_all("td")
            subcounter = 1
            for subEntry in cells:
                if(subcounter == 3):
                    tx_frequency = subEntry.text
                if(subcounter == 5):
                    rx_frequency = subEntry.text
                if(subcounter == 21):
                    description = subEntry.text
                if(subcounter == 7):
                    date = subEntry.text
                if(subcounter == 9):
                    location = subEntry.text
                subcounter += 1
        elif counter == 3:
            modulation = tableEntry.find("strong").text
            signal = tableEntry.find("strong").next_sibling.text
        elif counter == 4:
            service = entry
        elif counter == 5:
            owner = entry
        elif counter == 6:
            call = entry
        elif counter == 9:
            confirmations = entry
        elif counter == 10:
            conn.execute("INSERT INTO freq VALUES (?,?,?,?,?,?,?,?,?,?,?)", (tx_frequency, rx_frequency, location, date, modulation, signal, service, owner, call, description, confirmations))
            tx_frequency = rx_frequency = location = date = modulation = signal = service = owner = call = description = confirmations = ""        
            counter = 0
        counter += 1
    conn.commit()
    print "page {}".format(page+1)
conn.close()
