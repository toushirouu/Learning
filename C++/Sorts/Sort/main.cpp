#include<iostream>
#include<cstdlib>
#include<time.h>

using namespace std;
int tab[10];
int i,j,pomocnicza;

int main()
{
	srand(time(NULL));
	for (i=0;i<=9;i++)
	{
	tab[i]=rand()%100+1;
	cout<<tab[i]<<" ";
	}

cout<<endl;

	for(j=0;j<=9;j++)
	{
		for(i=0;i<=9;i++)
		{
			if(tab[i]>tab[i+1])
			{
				pomocnicza=tab[i+1];
				tab[i+1]=tab[i];
				tab[i]=pomocnicza;

			}
		}
	}

	for(i=0;i<=9;i++)
	{
		cout<<tab[i]<<" ";
	}

	return 0;

}
