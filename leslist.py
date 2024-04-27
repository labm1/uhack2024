import nid_poule 

#liste 
global prioritaire
global Nprioritaire
def ajouter_a_liste(x): # est une objet nidpoule
    if (x.profondeur==y) :
        if not (prioritaire.index(x.latitude) and prioritaire.index(x.longitude)):
            prioritaire.append(x)
    else :
        if not (Nprioritaire.index(x.latitude) and Nprioritaire.index(x.longitude)):
            Nprioritaire.append(x)

#envoyer list de travail au employer
def get_day_off_work():
    return gdow(dlistofwork)

def gdow(dlistofwork):
    if (len(prioritaire)+len(Nprioritaire)==0 or (len(dlistofwork)==40)):
        return dlistofwork
    if not prioritaire.len(0):
        return gdow(dlistofwork.append(prioritaire.pop(0)))
    else:
        return gdow(dlistofwork.append(Nprioritaire.pop(0)))

