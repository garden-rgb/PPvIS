#include <iostream>
#include "Graph.h"
int main(void)
{
	using namespace std;

	int chooseOperation = 0;
	string stringForIteration, stringForIteration_2;
	Graph<string>* GraphForOperations = new Graph<string>();

	while (true) {
		cout << "Enter numer of operation:" << endl;

		cout << "0. Exit" << endl;
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

		cin >> chooseOperation;
		switch (chooseOperation) {
		case 0:
		{
			return 0;
		}
		case 1:
		{
			cout << endl << "Enter node name: ";
			cin >> stringForIteration;
			GraphForOperations->addNode(stringForIteration);
			break;
		}
		case 2:
		{
			cout << endl << "Enter nodes names: ";
			cin >> stringForIteration >> stringForIteration_2;
			system("cls");
			GraphForOperations->addEdge(stringForIteration, stringForIteration_2);
			break;
		}
		case 3:
		{
			cout << endl << "Enter node name for delete: ";
			cin >> stringForIteration;
			system("cls");
			GraphForOperations->deleteNode(stringForIteration);
			break;
		}
		case 4:
		{
			cout << endl << "Enter nodes names: ";
			cin >> stringForIteration >> stringForIteration_2;
			system("cls");
			GraphForOperations->deleteEdge(stringForIteration, stringForIteration_2);
			break;
		}
		case 5: 
		{
			cout << endl << "Enter a file name: ";
			cin >> stringForIteration;
			system("cls");
			GraphForOperations->edgesFromFile(stringForIteration);
			break;
		}
		case 6: 
		{
			cout << endl << "Count of nodes: " << GraphForOperations->countOfNodes()
				<< endl << "Count of edges: " << GraphForOperations->countOfEdges()
				<< endl;
			system("cls");
			break;
		}
		case 7: 
		{

		}
		}
	}
}
