                    //This is a comment.
#include <iostream> //this is how you include files outside this one.
namespace spacename { //This is namespace. It stores values and functions.
    int number = 3; //these are data types.
    std::string word = "hello"; //They are considered primitive, since it comes with cpp.
    char letter = 'a';
    int add(int x, int y) { //This is a function. All functions need a type "int", and a return result.
        return x + y;       
    }
    }                   /**This is a multiline
                             comment**/
struct structure { /**This is struct. It stores values, functions, and constructors.
                    It is public, which can share its values**/

};
class crass {     /**This is class. It stores values, functions, and constructors.
                    It is private, which can't share its values.**/ 
    int height, weight;
    public:     //This makes things public. The "int main" function can use them now.
    crass() {       //constructors build datatypes. This is a default constructor.
        height = 0;
        weight = 0;
    }
    crass(int high, int weigh) {//This is a custom constructor.
        height = high;
        weight = weigh;
    }
    ~crass() {//This is a destructor. It is not important unless you use the "new" keyword.
              //The new keyword pulls memory off the heap. The program works with memory on the stack.
              //Without this, you would eventually fall to a memory leak, as the program would keep taking
              //and never give back.

    }
    int getWeight() {          //This is a function, or method. What it does is known as a getter or accessor.
        return weight;
    }
    void setWeight(int weigh) {  //This is a function, or method. What it does is known as a setter or mutator.
        weight = weigh;
        return;
    }
    int getHeight();    //This is a function reference. The method is at the bottom.
    void setHeight(int high); 
};

using namespace std; //This uses an entire namespace
using spacename::number; //This uses a specific thing in a namespace

int main() {    //This is the primary function to do stuff.
//std::cout, or cout, is how you display information.
    crass gold(4, 3); //This makes an object. This gold nugget is 4 inches tall and weighs 3 ounces.
    std::cout << gold.getWeight() << std::endl; //std::endl, or endl, is how you move to the next line.
    gold.setWeight(5);//This will change the gold's weight
    std::cout << gold.getWeight() << '\n';//New weight of gold. \n is a keyword that moves to the next line.
//std::cin, or cin, is how you get user input. There is also getline(cin, string)
    std::cout << spacename::add(number, 5) << std::endl;
    return 0;
}
    
    int crass::getHeight() {          //This is a function. Known as a getter. It's referenced at the top
        return height;
    }
    void crass::setHeight(int high) {  //This is a function. Known as a setter. It's referenced at the top
        height = high;
        return;
    }