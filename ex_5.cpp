#include <iostream>
using namespace std;

int main()
{
    double x, y;
    cout << "Enter x=";
    cin >>x;
    cout << "Enter y=";
    cin >>y;
    if (x*x+y*y<4 && x*x+y*y>1 && y<x)
    cout << "inside";
    else if (x*x+y*y==4 || x*x+y*y==1 || y==x)
    cout << "on the border";
    else 
    cout << "outside";
    return 0;
}
