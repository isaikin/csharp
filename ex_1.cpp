#include <iostream>
#include <iomanip>

#include <cmath>

using namespace std;

int main()
{
	int x, y;
	cout << "x=";
	cin >> x;
	cout << "y=";
	cin >> y;
	cout << fixed << setprecision(6);
	if (x>0 && y>0)
	cout << (double)(sin(pow(x, 3)) + pow(cos(y), 5) + 4*atan(1)*(log(x) / sqrt(x + log10(y))));
    else cout << "Error";

	return 0;
}
