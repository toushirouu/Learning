#include <iostream>
#include <stdlib.h>
#include <windows.h>

using namespace std;
string imie;
int liczba,i;
int main()
{
    cout << "Podaj imie" << endl;
    cin>>imie;
    cout << "Ile razy ma sie wypisac imie" <<endl;
    cin>>liczba;

    for(i=1; i<=liczba; i++)
    {
        Sleep(1000);
        system("cls");
        cout<<i<<". "<<imie<<endl;
    }
    system("PAUSE");
    return 0;
}
