#include <iostream>

using namespace std;

int main(){
    int testScore;

    cout<<"Etner your Marks: ";
    cin>>testScore;

    if(testScore >= 80){
        cout<<"Your grade is A";
    }
    else if(testScore >= 70){
        cout<<"Your grade is B";
    }
    else if(testScore >= 60){
        cout<<"Your grade is C";
    }
    else if(testScore >= 50){
        cout<<"Your grade is D";
    }
    else{
        cout<<"You failed this subject";
    }

    return 0;
}