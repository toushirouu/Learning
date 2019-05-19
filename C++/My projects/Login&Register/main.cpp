#include <iostream>
#include <stdlib.h>
#include <windows.h>
#include <string>
#include <conio.h>

using namespace std;
string uzytkownik1="szymon", haslo_uzytkownik1="wodamineralna";
string login, haslo, nowy_uzytkownik, nowy_haslo, weryfikacja;
int liczba1, liczba2, wynik;
char wybor,wybor1;
string logowanie();
string rejestracja();
string help();
string menu();
string liczby();
int dodawanie();
int odejmowanie();
int mnozenie();
int dzielenie();
int main()
{
    cout<<"Witaj w kalkulatorze!"<<endl;
    cout<<"1. Zaloguj"<<endl;
    cout<<"2. Rejestracja"<<endl;
    cout<<"3. Help"<<endl;
    cout<<"4. Wyjdz"<<endl;
    wybor1=getch();
    switch(wybor1){
case '1':
    logowanie();break;
case '2':
    rejestracja();
    logowanie();
    break;

case '3':
    cout<<"Slabi muszo zginac"<<endl;break; exit(0);
case '4':
    cout<<"Do zobaczenia!"<<endl; break; exit(0);
default:
    cout<<"Nie ma takiej opcji!"<<endl<<endl;
    main();
    break;
    }
    system("Pause");
}

string logowanie()
{
    cout<<"Podaj login"<<endl;
    cin>>login;
    cout<<"Podaj haslo"<<endl;
    cin>>haslo;
    if (((login==uzytkownik1) && (haslo==haslo_uzytkownik1)) || ((login==nowy_uzytkownik) && (haslo==nowy_haslo)))
    {
        cout<<"Witaj "<<login<<" jakich funkcji kalkulatora dzis uzyjesz?"<<endl;
    }
    else
    {
        cout<<"Bledny login lub haslo"<<endl;
        exit(0);
    }
    menu();
}
string rejestracja()
{

    cout<<"Podaj login nowe konta"<<endl;
    cin>>nowy_uzytkownik;
    cout<<"Podaj haslo nowego konta"<<endl;
    cin>>nowy_haslo;
    cout<<"Podaj drugi raz haslo"<<endl;
    cin>>weryfikacja;
    if (nowy_haslo==weryfikacja){
        cout<<"U¿ytkownik zosta³ zarejestrowany, mozesz sie zalogowac"<<endl;

    }
    else {cout<<"Hasla sie roznia! "<<endl;
    rejestracja();
    }
    }


string liczby()
{
        cout<<"Podaj pierwsza liczbe: ";
        cin>>liczba1;
        cout<<"Podaj druga liczbe: ";
        cin>>liczba2;
}
string menu()
{
    while(wybor!=5)
    {
    cout<<"Witaj w kalkulatorze!"<<endl;
    cout<<"---------------------"<<endl;
    cout<<"1. Dodawanie"<<endl;
    cout<<"2. Odejmowanie"<<endl;
    cout<<"3. Mnozenie"<<endl;
    cout<<"4. Dzielenie"<<endl;
    cout<<"5. Koniec programu"<<endl;
    wybor=getch();
    switch(wybor){
    case '1':
        cout<<"Wynik to: "<<dodawanie()<<endl<<endl; break;
    case '2':
        cout<<"Wynik to: "<<odejmowanie()<<endl<<endl; break;
    case '3':
        cout<<"Wynik to: "<<mnozenie()<<endl<<endl; break;
    case '4':
        cout<<"Wynik to: "<<dzielenie()<<endl<<endl; break;
    case '5':
        cout<<"Do zobaczenia, wcisnij enter by zakonczyc: "<<endl;
        getch();
        exit(0);
    default:
        cout<<"Nie ma takiej opcji!"<<endl;
        menu();    }
}
}
int dodawanie()
{
    liczby();
    wynik=liczba1+liczba2;
}
int odejmowanie()
{
    liczby();
    wynik=liczba1-liczba2;
}
int mnozenie()
{
    liczby();
    wynik=liczba1*liczba2;
}
int dzielenie()
{
    liczby();
    wynik=liczba1/liczba2;
}
