#include <iostream>
#include <string.h>

using namespace std;

int main(){

    string name;
    int a;
    int b;

    cout<<"Enter your name: ";
    cin>>name;

    cout<<"Enter value of a: ";
    cin>>a;

    cout<<"Enter value of b: ";
    cin>>b;

    cout<<"Your name is: " << name << endl;
    cout<<"Your final value is: " << a+b;

return 0;
}