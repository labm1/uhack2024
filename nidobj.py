import datetime
from PIL import Image
import time
import LatLon
from geopy.geocoders import Nominatim


class nid_poule:
    def __init__(self,profondeur,LatLon,photo):# photo = Image.open(path)
        self.palmyra = LatLon(x, y) # va utiliser latlon
        self.date= datetime.datetime.now()
        self.photo= photo

    
