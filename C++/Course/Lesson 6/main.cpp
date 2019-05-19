#include <iostream>
#include <stdlib>

using namespace std;
int populacja=1, godziny=0;

int main()
{
    while(populacja<=1000000000)
    {
        godziny++;
        populacja=populacja*2;
        cout<<"minelo godzin: " <<godziny<<endl;
        cout<<"liczba bakterii: " <<populacja<<endl;

    }

    return 0;
}
