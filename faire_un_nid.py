import datetime
from PIL import Image
import time
import LatLon
from geopy.geocoders import Nominatim
import nidobj
import numpy as np 
from PIL import Image as im 
import requests
#pour les request 311
#x est un string entrer par les cityen ou employer 
def request(x,photo):
    # Initialize Nominatim API
    geolocator = Nominatim(user_agent="MyApp")
    location = geolocator.geocode(x)
    numpy_array = np.array(photo)
    array = np.arange(0, 737280, 1, np.uint8)
    y=(location.latitude, location.longitude)
    n311= nidobj.nid_poule(profondeur,y,numpy_array)
    #envoyer vers serveur avec AI
    # vers_IA(n311)
    url=HTTP//132.213.172.11:8080/
    requests.post(url, n311)


#pour notre systeme automatique
#x serais la position donner par le gps
#
def req_automatique(x,photo):
    numpy_array = np.array(photo)
    auto= nidobj.nid_poule(profondeur,y,numpy_array)
     #envoyer vers serveur avec AI
    url=HTTP//132.213.172.11:8080/
    requests.post(url, auto)
    time.sleep(1) #temps pour eviter 
    