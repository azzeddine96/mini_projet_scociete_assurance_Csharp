
// travail demandé :

/* Une compagnie d'assurance automobile propose à ses clients quatre familles de tarifs
identifiables par une couleur, du moins au plus onéreux : tarifs bleu, vert, orange et rouge.
Le tarif dépend de la situation du conducteur :
- un conducteur de moins de 25 ans et titulaire du permis depuis moins de deux ans, se voit
attribuer le tarif rouge, si toutefois il n'a jamais été responsable d'accident. Sinon, la
compagnie refuse de l'assurer.
- un conducteur de moins de 25 ans et titulaire du permis depuis plus de deux ans, ou de
plus de 25 ans mais titulaire du permis depuis moins de deux ans a le droit au tarif orange
s'il n'a jamais provoqué d'accident, au tarif rouge pour un accident, sinon il est refusé.
- un conducteur de plus de 25 ans titulaire du permis depuis plus de deux ans bénéficie du
tarif vert s'il n'est à l'origine d'aucun accident et du tarif orange pour un accident, du tarif
rouge pour deux accidents, et refusé au-delà
De plus, pour encourager la fidélité des clients acceptés, la compagnie propose un contrat
de la couleur immédiatement la plus avantageuse s'il est entré dans la maison depuis plus
d'un an.
Ecrire un programme permettant de saisir les données nécessaires (sans contrôle de saisie) et
de traiter ce problème. Avant de se lancer à corps perdu dans cet exercice, on pourra
réfléchir un peu et s'apercevoir qu'ils est plus simple qu'il en a l'air (cela s'appelle faire une
analyse !) */


Console.WriteLine("veuillez saisir votre age");
int age = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("veuillez saisir votre age de permis");
int permis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("veuillez saisir votre nombre d'accident faites ");
int NmbrAccident = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("veuillez saisir votre ans d'abonnement (si vous n'aviez pas completer un ans entrer 0) ");
int AgeAbonn = Convert.ToInt32(Console.ReadLine());




if (AgeAbonn > 1)
{
    Console.WriteLine("client fidel , tarif special bleu");
}
else
{

    if (age > 25)
    {
        if (permis > 2)
        {
            if (NmbrAccident == 0)
            {

                Console.WriteLine("tarif vert");
            }
            else if (NmbrAccident == 1)
            {
                Console.WriteLine("tarif orange");
            }
            else if(NmbrAccident == 2)
            {
                Console.WriteLine("tarif rouge");
            }
            else
            {
                Console.WriteLine("refusé");
            }
        }
        else
        {
            if (NmbrAccident == 0)
            {

                Console.WriteLine("tarif orange");
            }
            else if(NmbrAccident == 1)
            {

                Console.WriteLine("tarif rouge");
            }
            else
            {
                Console.WriteLine("refusé");
            }
        }

    }
    else
    {
        if (permis > 2)
        {
            if (NmbrAccident == 0)
            {

                Console.WriteLine("tarif orange");
            }
            else if (NmbrAccident == 1)
            {
                Console.WriteLine("tarif rouge");
            }
            else
            {
                Console.WriteLine("refusé");
            }
        }
        else
        {
            if (NmbrAccident == 0)
            {

                Console.WriteLine("tarif rouge");
            }
            else
            {
                Console.WriteLine("refusé");
            }
        }
    }
}

Console.ReadKey();
