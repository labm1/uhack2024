import nid_poule 
import datetime
import LatLon
#liste 
global prioritaire
global Nprioritaire
global y # facteur qui determine si prioritaire ou non
global datacomplete
# ajouter a liste et blocker si deja existant
#les request faite en ligne du 311 arrive directement ici
#ceux des dashcams vont d abbord ce faire passer par le ai
def ajouter_a_liste(x): # est une objet nidpoule
    if (x.profondeur==y) :
        if not (prioritaire.index(x.coordinates)and erreurT (x,prioritaire) ):
            prioritaire.append(x)
    else :
        if not (Nprioritaire.index(x.coordinates)and erreurT (x,Nprioritaire)):
            Nprioritaire.append(x)
# retourn faux si a l interieur de 5 m pour reduire les repetition
def erreurT (x,y):
    T=x.coordinates
    for i in y:
        z=i.coordinates
        d=T.distantce.z
        if not  d> 0.005 :
         return False
    return True
    

#envoyer list de travail au employer
def get_day_off_work():
    if not(len(prioritaire)+len(Nprioritaire)==0 ):
        return gdow()

def gdow(dlistofwork):
    if ((len(dlistofwork)==40)):
        return dlistofwork
    if not len(prioritaire)==0:
        return gdow(dlistofwork.append(prioritaire.pop(0)))
    else:
        return gdownp(dlistofwork)

def gdownp(dlistofwork):
    if (len(Nprioritaire)==0 or (len(dlistofwork)==40)):
        return dlistofwork
    
    return gdownp(dlistofwork.append(Nprioritaire.pop(0)))

#remettre dans les listes les element non-reparer dans la liste de tache a faire
def noncomplete (dlistofwork):
    for x in dlistofwork:
         ajouter_a_liste(x)
    #remettre en ordre les liste
    prioritaire.sort(key=lambda date: datetime.strptime(date, "%D"))
    Nprioritaire.sort(key=lambda date: datetime.strptime(date, "%D"))

#suprimer les element reparer dans la liste de tache a faire
def complete (dlistofwork):
    for x in dlistofwork:
        if (prioritaire.index(x.coordinates) and  False==erreurT (x,prioritaire)):
           prioritaire.pop(prioritaire.index(x.coordinates))
        if  (Nprioritaire.index(x.coordinates) and False==erreurT (x,Nprioritaire)):
             Nprioritaire.pop(Nprioritaire.index(x.coordinates))
