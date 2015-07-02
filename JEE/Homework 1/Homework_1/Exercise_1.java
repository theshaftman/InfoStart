package Homework_1;


public class Exercise_1 {

	public String firstName;  
	public String lastName;
	public double markLith;
	public double markMath;
	public double markHistory;
	public double markInform;
	public double markIT;
	
	public static void main(String[] args) {
		Exercise_1 someOne = new Exercise_1("Ivan Todorov");
		someOne.marks(5.50, 6.00, 5.45, 6.00, 6.00);
		
//		someOne.markLith = 5.50;
//		someOne.markMath = 6.00;
//		someOne.markHistory = 5.45;
//		someOne.markInform = 6.00;
//		someOne.markIT = 6.00;
		
	}
	
	public Exercise_1(String fullName) {
		String[] name = fullName.split(" ");
		
		for (int i = 0; i < name.length; i++) {
			if (i == 0) {
				this.firstName = name[i];
			} else if (i == name.length - 1) {
				this.lastName = name[i];
			}
		}
	}
	
	public void marks(double markLith, double markMath, 
			double markHistory, double markInform, double markIT) {
		this.markLith = markLith;
		this.markMath = markMath;
		this.markHistory = markHistory;
		this.markInform = markInform;
		this.markIT = markIT;
		
		double gradePointAverage = ((markLith + markMath + markHistory + 
				markInform + markIT) / 5);
		
		if (gradePointAverage >= 5.5) {
			System.out.println("Excellent!");
		}
		
		System.out.printf("Grade Point Average of \"%s %s\": %.2f\n", 
				this.firstName, this.lastName, gradePointAverage);
		
		System.out.printf("BAL: %.3f", bal(this.markLith, this.markMath, 
				this.markInform, this.markIT));
	}
	
	public double bal(double markLith, double markMath, 
			double markInform, double markIT) {
		double markBAL;
		
		if (markInform >= markIT) {
			markBAL = (markLith + markMath + markInform) / 3;
			
			return markBAL;
		} else {
			markBAL = (markLith + markMath + markIT) / 3;
			
			return markBAL;
		}
	}

}
