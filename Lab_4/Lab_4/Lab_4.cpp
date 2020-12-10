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
		cout << "9. Iterator for nodes" << endl;
		cout << "10. Iterator for edges" << endl;
		cout << "11. Is node exist" << endl;
		cout << "12. Is edge exist" << endl;
		cout << "13. Is container empty" << endl;

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
			if (GraphForOperations->countOfNodes() == 0)
			{
				cout << "No nodes was found" << endl;
				system("cls");
				break;
			}
			GraphForOperations->showNodes();
			system("cls");
			break;
		}
		case 8:
		{
			if (GraphForOperations->countOfEdges() == 0)
			{
				cout << "No edges";
				system("cls");
				break;
			}
			GraphForOperations->showEdges();
			system("cls");
			break;
		}
		case 9:
		{
			Graph<string>::Node_Iterator Graph_iterator(*GraphForOperations);
			while (chooseOperation)
			{
				cout << endl << "1. Next node" << endl;
				cout << "2. Previous node" << endl;
				cout << "3.Get adjacent nodes" << endl;
				cout << "4.Get incident edges" << endl;
				cout << "5.Exit" << endl;
				cout << "Your choise: ";
				cin >> chooseOperation;
				switch (chooseOperation) {
				case 1:
				{
					if (Graph_iterator.next() == false)
					{
						cout << endl << "Iterator is on the last node" << endl;
					}
					else
					{
						cout << endl << "Iterator moved to next node" << endl;
					}
					break;
				}
				case 2:
				{
					if (Graph_iterator.prev() == false)
					{
						cout << endl << "Iterator is on the first node" << endl;
					}
					else
					{
						cout << endl << "Iterator moved to previous node" << endl;
					}
					break;
				}
				case 3:
				{
					Graph_iterator.getAdjacentNodes();
					break;
				}
				case 4:
				{
					Graph_iterator.getIncidentEdges();
					break;
				}
				case 5:
					system("cls");
					break;
				}
			}
			break;
		}
		case 10: {
			cout << endl << "Enter node name: ";
			cin >> stringForIteration;
			if (GraphForOperations->isNodeExist(stringForIteration) != -1)
			{
				cout << endl << "This node exist" << endl;
			}
			else
			{
				cout << endl << "This node doesn't exist" << endl;
			}
			system("cls");
			break;
		}
		case 11: {
			Graph<string>::Node_Iterator Graph_iterator(*GraphForOperations);
			while (chooseOperation)
			{
				cout << endl << "1. Next edge" << endl;
				cout << "2. Previous edge" << endl;
				cout << "3. Exit" << endl;
				cout << endl << "Enter your choice: ";
				cin >> chooseOperation;

				switch (chooseOperation)
				{
				case 1:
				{
					if (Graph_iterator.next() == false)
					{
						cout << endl << "Iterator is on the last edge" << endl;
					}
					else
					{
						cout << endl << "Iterator moved to next edge" << endl;
					}
					break;
				}
				case 2:
				{
					if (Graph_iterator.prev() == false)
					{
						cout << endl << "Iterator is on the first edge" << endl;
					}
					else
					{
						cout << endl << "Iterator moved to previous edge" << endl;
					}
					break;
				}
				case 3:
					system("cls");
					break;
				}
			}
			break;
		}
		case 12: {
			cout << endl << "Enter nodes names: ";
			cin >> stringForIteration >> stringForIteration_2;
			if (GraphForOperations->isEdgeExist(stringForIteration, stringForIteration_2) != -1)
			{
				cout << endl << "This edge exist" << endl;
			}
			else
			{
				cout << endl << "This edge doesn't exist" << endl;
			}
			system("cls");
			break;

		}
		case 13: {
			if (GraphForOperations->empty() == true) {
				cout << endl << "Empty" << endl;
			}
			else {
				cout << endl << "Not empty" << endl;
			}
			system("cls");
			break;
		}
		}
	}
}
