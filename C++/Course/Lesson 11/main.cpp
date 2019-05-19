#include <iostream>

using namespace std;
string imie;
int main()
{
    cout << "Podaj imie" << endl;
    cin>>imie;
    int dlugosc=imie.length();
    if(imie[dlugosc-1]=='a')
        cout<<"Wydaje mi sie, ze jestes kobieta"<<endl;
    else cout<<"Wydaje mi sie, ze jestes facetem"<<endl;

    return 0;
}
