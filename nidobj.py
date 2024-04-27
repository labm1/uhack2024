import datetime
from PIL import Image
class nid_poule:
    def __init__( latitude , longitude,profondeur,time,photo):# photo = Image.open(path)
        latitude =latitude
        longitude= longitude
        profondeur=profondeur
        time= datetime.datetime.now()
        photo= photo

