package Homework_1;

import java.util.Scanner;

public class Exercise_2 {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Enter a \"N\" number between 0 and 9: ");
		String next = scanner.next();
		
		try {
			int number = Integer.parseInt(next);
			
			if ((number >= 0) && (number <= 9)) {
				int first = 0;
				int second = 1;
				int result = 0;
				
				if (number == 1) {
					result = 1;
				}
				
				for (int i = 2; i <= number; i++) {
					result = first + second;
					first = second;
					second = result;
				}
				
				System.out.println(result);
			} else {
				System.out.println("Error! Try with a Number between 0 and 9!");
			}
		} catch (NumberFormatException e){
			System.out.println("Error! Try with a int NUMBER!");
		}
		
		scanner.close();
	}

}
