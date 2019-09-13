#include <iostream>
#include <cmath>

using namespace std;
int main()
{
  int x;
  cout << "Enter your number=";
  cin >> x;
  int k=0, n=x;
  while (x>0)
  {
      k++;
      x/=10;
  }
  int t=0;
  while (n>0)
  {
   t+=(n%10)*(pow(10, k-1));
   k--;
   n/=10;
   
  }
  cout << "New number=" << t;
  return 0;
}
