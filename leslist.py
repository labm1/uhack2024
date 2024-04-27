import nid_poule 
import datetime
#liste 
global prioritaire
global Nprioritaire
global y # facteur qui determine si prioritaire ou non
def ajouter_a_liste(x): # est une objet nidpoule
    if (x.profondeur==y) :
        if not (prioritaire.index(x.latitude) and prioritaire.index(x.longitude)):
            prioritaire.append(x)
    else :
        if not (Nprioritaire.index(x.latitude) and Nprioritaire.index(x.longitude)):
            Nprioritaire.append(x)

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

def noncomplete (dlistofwork):
    for x in dlistofwork:
         ajouter_a_liste(x)
    #remettre en ordre les liste
    prioritaire.sort(key=lambda date: datetime.strptime(date, "%D"))
    Nprioritaire.sort(key=lambda date: datetime.strptime(date, "%D"))




