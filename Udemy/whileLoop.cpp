#include <iostream>
using namespace std;

int main(){

    int counter = 0;
    bool check = true;
    int errorNumber = 32;

    while(counter <= 100 && check){
        cout<<counter<<endl;
        if(counter == errorNumber) check = false;
        counter++;
    }

return 0;
}