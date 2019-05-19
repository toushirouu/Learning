#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <Windows.h>

using namespace std;
int liczba, strzal, ilosc_prob;
int main()
{
    cout << "Witaj, pomyslalem sobie liczbe od 1..100, zgadnij jaka: " << endl;
    srand(time(NULL));
    liczba=rand()%100+1;
    cout<<liczba;
    while(strzal!=liczba)
    {
    ilosc_prob++;
    cout <<"Podaj liczbe: "<<"To Twoja "<<ilosc_prob<<" proba"<<endl;
    cin >> strzal;

    if (strzal==liczba){
        cout<<"Wygrales! w "<<ilosc_prob<<" probie!"<<endl;

    }
    else if(strzal>liczba)
        cout<<"To zbyt duza liczba"<<"\a"<<endl;

    else if(strzal<liczba)
        cout<<"To zbyt mala liczba"<<"\a"<<endl;

    }


    return 0;
}
