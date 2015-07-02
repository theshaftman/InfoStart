package Homework_1;

import java.util.Scanner;

public class Exercise_2_26 {
	
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Enter a \"N\" number between 0 and 9: ");
		String next = scanner.next();
		
		try {
			int number = Integer.parseInt(next);
			
			if ((number >= 0) && (number <= 9)) {
				System.out.println(fibonacci(number));
			} else {
				System.out.println("Error! Try with a Number between 0 and 9!");
			}
		} catch (NumberFormatException e){
			System.out.println("Error! Try with a int NUMBER!");
		}
		
		scanner.close();
	}
	
	public static int fibonacci(int number) {
		if (number == 0) return 0;
	    if (number == 1) return 1;
	 
	    return fibonacci(number - 1) + fibonacci(number - 2);
	}
	
}
