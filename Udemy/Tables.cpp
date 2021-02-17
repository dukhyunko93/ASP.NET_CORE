#include <iostream>
using namespace std;

int main() {
    int table;

    cout<<"Enter a number: ";
    cin>>table;

    int count = 1;

    while(count <= 10){
        cout<<table<<" * "<<count<<" = "<<table*count<<endl;
        count++;
    }

    return 0;
}