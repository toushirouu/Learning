#include <iostream>
#include <stdlib.h>
using namespace std;
int pin, kwota;
int stan_konta=5000;
string potwierdzenie;
int main()
{
    cout << "Witaj podaj pin: ";
    cin>>pin;
    if (pin == 3142)
    {
        cout<<"Prawidlowy pin"<<endl;

    }
    else
    {
        cout<<"Bledne haslo, wylogowywanie"<<endl;
        system("PAUSE");
        return 0;

    }
    cout <<"Ile chcesz wyplacic pieniedzy"<<endl;
    cin>>kwota;
    if(kwota==5000)
    {
        cout<<"Odbierz swoje pieniadze, czy drukowac potwierdzenie?"<<endl<<"Wpisz tak lub nie"<<endl;
        cin>>potwierdzenie;
    }
    else if (kwota>5000)
    {
        cout<<"Zbyt duza kwota, brak wystarczajacych srodkow na koncie"<<endl;
        return 0;
    }
    else if (kwota<=5000)
    {
        cout<<"Odbierz swoje pieniadze"<<endl;
    }
    else
    {
        cout<<"Błedna wartosc"<<endl;
        return 0;
    }

    cout<<"Czy drukowac potwierdzenie, wpisz tak lub nie"<<endl;
    cin>>potwierdzenie;
    if(potwierdzenie=="tak")
        {
            cout<<"Odbierz paragon"<<endl;
        }
        else{
            cout<<"Dziekujemy za wyplate"<<endl;
        }
            cout<<"Zapraszamy ponownie"<<endl;

         system("PAUSE");
         return 0;
}


