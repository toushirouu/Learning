#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

struct osoba {
    string imie;
    string nazwisko;
    int wiek;
    osoba *nastepna;    // wskaźnik na następny element
    osoba();            // konstruktor
};

osoba::osoba() {
    nastepna = 0;       // konstruktor
}

struct lista {
    osoba *pierwsza;  // wskaźnik na początek listy
    void dodaj_osobe (string imie, string nazwisko, int wiek);
    void usun_osobe (int nr);
    void wyswietl_liste ();
    lista();
};

lista::lista() {
    pierwsza = 0;       // konstruktor
}

void lista::dodaj_osobe(string imie, string nazwisko, int wiek)
{
    osoba *nowa = new osoba;    // tworzy nowy element listy

    // wypełniamy naszymi danymi
    nowa->imie = imie;
    nowa->nazwisko = nazwisko;
    nowa->wiek = wiek;

    if (pierwsza==0) // sprawdzamy czy to pierwszy element listy
    {
        // jeżeli tak to nowy element jest teraz początkiem listy
        pierwsza = nowa;
    }

    else
    {
        // w przeciwnym wypadku wędrujemy na koniec listy
        osoba *temp = pierwsza;

        while (temp->nastepna)
        {
            // znajdujemy wskaźnik na ostatni element
            temp = temp->nastepna;
        }

        temp->nastepna = nowa;  // ostatni element wskazuje na nasz nowy
        nowa->nastepna = 0;     // ostatni nie wskazuje na nic
    }
}

int main()
{
    lista *baza = new lista;    //tworzymy liste

    //dodajemy rekordy do bazy
    baza->dodaj_osobe("maciej","pierwszy", 23);
    baza->dodaj_osobe("arkadiusz","drugi", 44);
    baza->dodaj_osobe("dariusz","trzeci", 19);
    baza->dodaj_osobe("andrzej","czwarty", 21);

    // wyswietlamy 1 osobę - macieja
    cout << baza->pierwsza->imie << endl;

    // wyswietlamy 2 osobę - arkadiusza
    cout << baza->pierwsza->nastepna->imie << endl;

    // wyswietlamy wiek 3 osoby - dariusza
    cout << baza->pierwsza->nastepna->nastepna->wiek << endl;

    // wyswietlamy wiek 4 osoby - andrzeja
    cout << baza->pierwsza->nastepna->nastepna->nastepna->wiek << endl;

    delete (baza);

    return 0;
}

void lista::wyswietl_liste()
{
    // wskaznik na pierszy element listy
    osoba *temp = pierwsza;

    // przewijamy wskazniki na nastepne elementy
    while (temp)
    {
        cout << "imie: " << temp->imie << " nazwisko: " << temp->nazwisko << endl;
        temp=temp->nastepna;
    }
}

void lista::usun_osobe (int nr)
{
    // jezeli to pierwszy element listy
    if (nr==1)
    {
        osoba *temp = pierwsza;
        pierwsza = temp->nastepna; //poczatek listy, 1 el. wskazuje na 2 el. itd..
    }

    // jeżeli nie jest to pierwszy element
    if (nr>=2)
    {
        int j = 1;

        // do usuniecia srodkowego elemetnu potrzebujemy wskaznika na osobe n-1
        // wskaznik *temp bedzie wskaznikiem na osobe poprzedzajaca osobe usuwana
        osoba *temp = pierwsza;

        while (temp)
        {
            // sprawdzamy czy wskaznik jest na osobie n-1 niz usuwana
            if ((j+1)==nr) break;

            // jezeli nie to przewijamy petle do przodu
            temp = temp->nastepna;
            j++;
        }

        // wskaznik *temp wskazuje teraz na osobe n-1
        // nadpisujemy wkaznik osoby n na osobe n+1
        // bezpowrotnie tracimy osobe n-ta

        // dodatkowo sprawdzamy czy aby nie jest to ostatni element
        // wtedy nalezy wyzerowac ostatni wskaznik
        if (temp->nastepna->nastepna==0)
            temp->nastepna = 0;

        // jezeli nie byl to ostatni element
        else
            temp->nastepna = temp->nastepna->nastepna;
    }
}
