#include <iostream>
using namespace std;

int main(){
    int result = 1;
    int userInput;
    cout<<"How many times you want loop to run: ";
    cin>>userInput;

for(int i = userInput; i > 0; i--){
    result = result * i;
}
    cout<<result;
return 0;
}