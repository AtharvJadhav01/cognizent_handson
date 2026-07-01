#include <iostream>
#include <string>
using namespace std;

class Product {
public:
    int productId;
    string productName;
    string category;

    Product() {}

    Product(int id, string name, string cat) {
        productId = id;
        productName = name;
        category = cat;
    }

    void display() {
        cout << "Product ID: " << productId << endl;
        cout << "Product Name: " << productName << endl;
        cout << "Category: " << category << endl;
    }
};

// Linear Search
int linearSearch(Product products[], int size, int key) {
    for (int i = 0; i < size; i++) {
        if (products[i].productId == key)
            return i;
    }
    return -1;
}

// Binary Search (Array must be sorted)
int binarySearch(Product products[], int size, int key) {
    int low = 0;
    int high = size - 1;

    while (low <= high) {
        int mid = (low + high) / 2;

        if (products[mid].productId == key)
            return mid;
        else if (products[mid].productId < key)
            low = mid + 1;
        else
            high = mid - 1;
    }

    return -1;
}

int main() {

    Product products[] = {
        Product(101, "Laptop", "Electronics"),
        Product(102, "Phone", "Electronics"),
        Product(103, "Shoes", "Fashion"),
        Product(104, "Watch", "Accessories"),
        Product(105, "Book", "Education")
    };

    int size = sizeof(products) / sizeof(products[0]);

    int searchId;
    cout << "Enter Product ID to search: ";
    cin >> searchId;

    cout << "\nLinear Search:\n";
    int index = linearSearch(products, size, searchId);

    if (index != -1)
        products[index].display();
    else
        cout << "Product not found." << endl;

    cout << "\nBinary Search:\n";
    index = binarySearch(products, size, searchId);

    if (index != -1)
        products[index].display();
    else
        cout << "Product not found." << endl;

    return 0;
}