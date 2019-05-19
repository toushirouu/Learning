#include <iostream>
#include <windows.h>
#include <stdlib.h>
#include <conio.h>
#include <stdio.h>

using namespace std;
float liczba1, liczba2;
char wybor;
int main()
{
    for(;;){
    cout << "Witaj w kalkulatorze" << endl;

    cout << "Podaj pierwsza liczbe"<<endl;
    cin >> liczba1;

    cout << "Podaj druga liczbe"<<endl;
    cin >>liczba2;

    cout << "MENU GLOWNE" <<endl;
    cout << "------------"<<endl;
    cout << "1. Dodawanie"<<endl;
    cout << "2. Odejmowanie"<<endl;
    cout << "3. Mnozenie"<<endl;
    cout << "4. Dzielenie"<<endl;
    cout << "5. Koniec programu"<<endl;
    cout << endl;
    wybor=getch();

    switch (wybor)
    {

    case '1':
        cout<<"Wynik dodawania dwoch liczb to: "<<liczba1+liczba2<<endl;
        break;
    case '2':
        cout<<"Wynik odejmowania dwoch liczb to: "<<liczba1-liczba2<<endl;
        break;
    case '3':
        cout<<"Wynik mnozenia dwoch liczb to: "<<liczba1*liczba2<<endl;
        break;
    case '4':
        if (liczba2==0)
        {
            cout<<"Nie dziel przez zero"<<endl;
            exit(0);
        }
        cout<<"Wynik dzielenia dwoch liczb to: "<<liczba1/liczba2<<endl;
        break;
    case '5':
        exit(0);

    default:
        cout<<"Nie ma takiej opcji w menu!"<<endl;
    }

    getchar();getchar();
    system("cls");
    }
    system("PAUSE");

    return 0;

}
