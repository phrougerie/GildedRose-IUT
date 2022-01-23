Première étape: 


Sortir le for et appeler le updateQuality.



Deuxième étape:



Inverser les opérandes. Il va s'agir de switcher les opérandes et do sortir les conditions booléennes.
Si on a un if avec un opérande "!" on inverse le if.

Exemple:

if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
{
    Items[i].Quality = Items[i].Quality - 1;
}

if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
{
}
else
{
    Items[i].Quality = Items[i].Quality - 1;
}


Troisième étape:

On efface les conditions Sulfuras et on la met dans une première condition de garde. En effet celle-ci s'ouvre sur une condition vide.

Quatrième étape:

Extraction dans des méthodes de item.Quality = item.Quality - 1; et item.Quality = item.Quality + 1;