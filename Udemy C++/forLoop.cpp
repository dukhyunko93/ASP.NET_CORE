#include <iostream>
using namespace std;

int main(){

    int userInput;
    cout<<"How many times you want loop to run: ";
    cin>>userInput;

for(int i = 0; i <= userInput; i++){
    cout<<i<<endl;
}

return 0;
}