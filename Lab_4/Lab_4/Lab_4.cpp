#include <iostream>
#include "Graph.h"
int main(void)
{
	using namespace std;
	
	int chooseOperation = 0;

	Graph<string>* GraphForOperations = new Graph<string>();

	while (true) {
		cout << "Enter numer of operation:" << endl;
		
		cout << "1. Add node" << endl;
		cout << "2. Add edge" << endl;
		cout << "3. Delete node" << endl;
		cout << "4. Delete edge" << endl;
		cout << "5. Import from file" << endl;
		cout << "6. Number of edges and nodes" << endl;
		cout << "7. Show nodes" << endl;
		cout << "8. Show edges" << endl;
		cout << "9. Degree of node" << endl;
		cout << "10. Iterator for nodes" << endl;
		cout << "11. Iterator for edges" << endl;
		cout << "12. Is node exist" << endl;
		cout << "13. Is edge exist" << endl;
		cout << "14. Is container empty" << endl;
		cout << "15. Clear" << endl;
		cout << "0. Exit" << endl;

		cin >> chooseOperation;
	}

}

