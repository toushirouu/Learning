#include <iostream>
#include <stdlib.h>

using namespace std;

int x,y,z,b;
int main()
{
    cout << "Ile osob liczy twoja klasa" << endl;
    cin>>x;
    cout << "Ile cukierkow kupila mama" << endl;
    cin>>y;
    z = (x-1)*2;
    b = y-z;
    cout << "Jas moze zjesc "<<b << " cukierkow" <<endl;
    system("PAUSE");
  return 0;
}
