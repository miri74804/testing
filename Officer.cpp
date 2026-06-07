#include "Officer.h"
#include <iostream>

Officer::Officer(string id, string fname, string lname, int count, double mark) :Soldier(id, fname, lname, count), mark(mark) {}
bool Officer::medal() {
	return count > 2 && mark >= 92;
}
void Officer::print() {
	cout << soldierType() << endl;
	Soldier::print();
	cout << "mark: " << mark << endl;
}
double Officer::getMark() {
	return mark;
}

int y = 0;}

int x = 0;
