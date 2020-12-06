#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using namespace std;

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
class Edge {
	int begin;
	int end;
public:
	Edge(int _begin = 0, int _end = 0)
	{
		begin = _begin;
		end = _end;
	}
	short getBegin()
	{
		return begin;
	}
	short getEnd()
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
template <typename T>
class Graph {
private:
	vector<Node<T>> node;
	vector<Edge> edge;
public:
	Graph(void) {};
	~Graph(void) {};

	void addNode(T _nodeObject)
	{
		if (isNodeExist(_nodeObject) == -1)
		{
			node.push_back(Node<T>(_nodeObject));
		}
	};
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
	void addEdge(T iObject, T jObject)
	{
		int i = isNodeExist(iObject), j = isNodeExist(jObject);
		if (i != -1 && j != -1 && isEdgeExist(i, j) == false)
		{
			edge.push_back(Edge(isNodeExist(iObject), isNodeExist(jObject)));
		}
	};
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

};