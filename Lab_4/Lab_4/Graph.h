#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using namespace std;
/// <summary>
/// Шаблон класса для записи и получения вершины
/// </summary>
/// <typeparam name="T"></typeparam>
template <typename T> 
class Node {
private:
	T node;
public:
	Node(T _node = T())
	{
		node = _node;
	}
	string getObject()
	{
		return node;
	}
};
/// <summary>
/// Класс ребра графа
/// </summary>
class Edge {
	int begin;
	int end;
public:
	Edge(int _begin = 0, int _end = 0)
	{
		begin = _begin;
		end = _end;
	}
	int getBegin()
	{
		return begin;
	}
	int getEnd()
	{
		return end;
	}
	void setBegin(int _begin)
	{
		begin = _begin;
	}
	void setEnd(int _end)
	{
		end = _end;
	}
};
/// <summary>
/// Шаблон класса для работы с графом
/// </summary>
/// <typeparam name="T"></typeparam>
template <typename T>
class Graph {
private:
	vector<Node<T>> node;
	vector<Edge> edge;
public:
	/// <summary>
	/// Конструктор и деструктор
	/// </summary>
	/// <param name=""></param>
	Graph(void) {};
	~Graph(void) {};
	/// <summary>
	/// Добавление вершины
	/// </summary>
	/// <param name="_nodeObject"></param>
	void addNode(T _nodeObject)
	{
		if (isNodeExist(_nodeObject) == -1)
		{
			node.push_back(Node<T>(_nodeObject));
		}
	};
	/// <summary>
	/// Удаление вершины
	/// </summary>
	/// <param name="_nodeObject"></param>
	void deleteNode(T _nodeObject)
	{
		short _nodeNumber = isNodeExist(_nodeObject);
		if (_nodeNumber != -1)
		{
			node.erase(node.begin() + _nodeNumber);
			for (int i = 0; i < edge.size(); i++)
			{
				if (isEdgeExist(i, _nodeNumber))
				{
					deleteEdge(i, _nodeNumber);
				}
			}
		}
	}
	/// <summary>
	/// Добавление ребра
	/// </summary>
	/// <param name="iObject"></param>
	/// <param name="jObject"></param>
	void addEdge(T iObject, T jObject)
	{
		int i = isNodeExist(iObject), j = isNodeExist(jObject);
		if (i != -1 && j != -1 && isEdgeExist(i, j) == false)
		{
			edge.push_back(Edge(isNodeExist(iObject), isNodeExist(jObject)));
		}
	};
	/// <summary>
	/// Удаление ребра
	/// </summary>
	/// <param name="iObject"></param>
	/// <param name="jObject"></param>
	void deleteEdge(T iObject, T jObject)
	{
		for (int k = 0; k < edge.size(); k++)
		{
			if (isEdgeExist(iObject, jObject) != -1)
			{
				edge.erase(edge.begin() + k);
			}
		}
	};
	/// <summary>
	/// Получение ребер из файла
	/// </summary>
	/// <param name="filename"></param>
	void edgesFromFile(string filename)
	{
		ifstream inputFileStream;
		inputFileStream.open(filename);
		if (!inputFileStream.is_open() == true)
		{
			inputFileStream.close();
			return;
		}
		short beginNode = 0, endNode = 0;
		while (inputFileStream.eof() == false)
		{
			inputFileStream >> beginNode >> endNode;
			if (beginNode >= node.size() || endNode >= node.size())
			{
				continue;
			}
			edge.push_back(Edge(beginNode, endNode));
		}
		inputFileStream.close();
	};
	/// <summary>
	/// Проверка существования рёбер
	/// </summary>
	/// <param name="iObject"></param>
	/// <param name="jObject"></param>
	/// <returns></returns>
	int isEdgeExist(T iObject, T jObject)
	{
		for (int k = 0; k < edge.size(); k++)
		{
			if ((node[edge[k].getBegin()].getObject() == iObject && node[edge[k].getEnd()].getObject() == jObject) ||
				(node[edge[k].getBegin()].getObject() == jObject && node[edge[k].getEnd()].getObject() == iObject))
			{
				return k;
			}
		}
		return -1;
	};
	/// <summary>
	/// Проверка существования вершин
	/// </summary>
	/// <param name="_nodeObject"></param>
	/// <returns></returns>
	int isNodeExist(T _nodeObject)
	{
		for (int i = 0; i < node.size(); i++)
		{
			if (node[i].getObject() == _nodeObject)
			{
				return i;
			}
		}
		return -1;
	};
	/// <summary>
	/// Количество вершин графа
	/// </summary>
	/// <returns></returns>
	int countOfNodes()
	{
		return node.size();
	};
	/// <summary>
	/// Количество ребёр графа
	/// </summary>
	/// <returns></returns>
	int countOfEdges()
	{
		return edge.size();
	};
	/// <summary>
	/// Вывод вершин графа
	/// </summary>
	void showNodes()
	{
		cout << endl;
		for (int i = 0; i < node.size(); i++)
		{
			cout << node[i].getObject() << endl;
		}
	};
	/// <summary>
	/// Вывод рёбер графа
	/// </summary>
	void showEdges()
	{
		cout << endl;
		for (int i = 0; i < edge.size(); i++)
		{
			cout << node[edge[i].getBegin()].getObject() << " - " << node[edge[i].getEnd()].getObject() << endl;
		}
	};
	/// <summary>
	/// Проверка на пустой контейнер
	/// </summary>
	/// <param name=""></param>
	/// <returns></returns>
	bool empty(void)
	{
		if (node.size() == 0)
		{
			return true;
		}
		return false;
	}
	/// <summary>
	/// Итератор для вершин
	/// </summary>
	class Node_Iterator {
	private:
		Graph<T>* graphIteration;
		int index;
	public:
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="graph"></param>
		Node_Iterator(Graph<T>& graph)
		{
			graphIteration = &graph;
			index = 0;
		}
		bool next()
		{
			if (graphIteration->node.size() <= index + 1)
			{
				return false;
			}
			index++;
			return true;
		}
		bool prev()
		{
			if (index == 0)
			{
				return false;
			}
			index--;
			return true;
		}
		/// <summary>
		/// Перебор вершин, смежных вершине
		/// </summary>
		void getAdjacentNodes()
		{
			short countOfAdjacent = 0;
			cout << endl;
			for (int i = 0; i < graphIteration->node.size(); i++)
			{
				if (graphIteration->isEdgeExist(index, i) == true)
				{
					countOfAdjacent++;
					cout << graphIteration->node[i].getObject() << ' ';
				}
			}
			if (countOfAdjacent == 0)
			{
				cout << "No nodes adjacent";
			}
			cout << endl;
		}
		/// <summary>
		/// Перебор рёбер, инцидентных вершине 
		/// </summary>
		void getIncidentEdges()
		{
			cout << endl;
			short countOfIncident = 0;
			for (int i = 0; i < graphIteration->node.size(); i++)
			{
				if (graphIteration->isEdgeExist(index, i) == true)
				{
					countOfIncident++;
					cout << graphIteration->node[index].getObject() << " - " << graphIteration->node[i].getObject() << endl;
				}
			}
			if (countOfIncident == 0)
			{
				cout << "No edges incident";
			}
			cout << endl;
		}


	};
	/// <summary>
	/// Итератор для рёбер
	/// </summary>
	class Edge_iterator
	{
	private:
		Graph<T>* graphForIteration;
		int index;
	public:
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="graph"></param>
		Edge_iterator(Graph<T>& graph)
		{
			graphForIteration = &graph;
			index = 0;
		}
		bool next()
		{
			if (graphForIteration->edge.size() <= index + 1)
			{
				return false;
			}
			index++;
			return true;
		}
		bool prev()
		{
			if (index == 0)
			{
				return false;
			}
			index--;
			return true;
		}
	}
};