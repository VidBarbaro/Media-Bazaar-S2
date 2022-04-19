# Media Bazaar
Desktop and Web marketplace made in semester 2 of the Software Enginnering specialisation at Fontys ICT. Project owner: Fontys </br>

# Intro

Desktop app developed with C#(frontend and backend), web app developed with HTML/CSS(frontend) and PHP(backend) with MySQL(database).

## Description

The idea behind Media Bazaar is that managers and higher level positions inside a company can have a better digitalized view over their employees and products. At the same time those managers can view certain statistics from employees and products and implement helpfull changes inside the physical store.

1. What is it about?
 - The desktop app is made specifically for managers(employee, product and department). 
 - Employee managers can generate(manually or automatically with an algorithm) weekly shifts and accept holiday or sick day requests. They have an extensive view of statistics personalized for each employee, allowing the managers to keep track of employees who are doing their job good and those who are performing bellow average.
 -  Product managers have the ability to manage products(CRUD) and see details and statistics of each product like stock number and how many times has it been sold. They have an overview of restock requests from their employees and they can either accept or deny them. Product managers can also change categories for certain products and see statistics of each category(laptops, smart phones..etc)
 -  Department managers have an overview of each department, how many employees does it need to function properly in total and for each shift and how many are available, then with that information they can make changes in the shift schedule and in the employee hiring process. As all the managers the department manager has an overview of statistics unique for each department and one statistics that compares all the departments to each other.
2. Why C# and HTML/CSS, PHP?
 - At the start of the project we were required to develop just a desktop applications for managers with C# and MySQL. We were required to design a class diagram and implement the SOLID design principles. 
 - The reason behind using HTML/CSS and PHP to develop the website was simply because those were the only languages we used in the previous semester and thus we were required to develop with them and not waste time learning new frameworks/languages.
 - Combining the desktop app with the web app proved to be challenging at the time but definetely managable.
3. Challenges faced?
 - The biggest challenge was desigining and implementing the automatic shift scheduler algorithm so that a weekly schedule can be created for all the employees that exists for each department and accomodating all the basic personel number needs.
 - Another challenge was working online since CoVid19 didn't allow on site teaching and learning.

### How to use the project

1. After logging in this is the screen all the managers are greeted with</br> </br>
![After logging in](https://user-images.githubusercontent.com/76628104/164078095-d7b3f823-bcac-49a4-8a5e-7a69c1a0fe5b.jpg)
 </br> </br>
2. The pending free day request screen allows the manager to view, search, filter, accept and delete all pending free day requests</br> </br>
![Free day requests](https://user-images.githubusercontent.com/76628104/164078412-52631715-c74b-448b-b6ee-ecd563ea1659.jpg)
</br></br>
Same possibilities are offered to the product manager
</br></br>
![Product restock request](https://user-images.githubusercontent.com/76628104/164078680-08852098-0be6-4fd5-83d4-ac0dbc53449f.jpg)
 </br> </br>
3. On their profile page the managers can view their basic informations and how many sick/holiday days they have left</br> </br>
![Profile page](https://user-images.githubusercontent.com/76628104/164079541-59607ada-a502-4163-af73-2c258f500895.jpg)
</br></br>
Pressing on one of the request buttons will make a pop up window appear allowing them to make a date choice and reason for sick day/holiday
</br></br>
![Holiday request](https://user-images.githubusercontent.com/76628104/164079553-22320302-3a38-4391-842f-215539d8432f.jpg)
</br></br>
![Sick day request](https://user-images.githubusercontent.com/76628104/164080115-ec0310c7-0635-42a3-bb32-91396c645602.jpg)
</br></br>
4. Employee managers can view shifts for the current day, selected employees and for a certain selected date in the future. They can manually add, remove or update shifts for a selected employee.</br></br>
![Shift management](https://user-images.githubusercontent.com/76628104/164080493-ea4279a6-9dcb-46a7-b476-7ec80b37438f.jpg)
 </br> </br>
5. Some general employee statistics </br> </br>
![General employee statistics](https://user-images.githubusercontent.com/76628104/164084626-a9a5cc54-7a44-41bd-87a4-74a49d99b77a.jpg)</br> </br>
Personalized statistics per employee
</br> </br>
![Personalized statistics](https://user-images.githubusercontent.com/76628104/164084809-8c4e3e58-9a59-438b-8744-15f5558cd89b.jpg)
 </br> </br>
Same for the product manager and general product statistics
![General product statistics](https://user-images.githubusercontent.com/76628104/164084910-e1dc1635-a87f-406e-82ad-a253efea0c59.jpg)
 </br> </br>
And personal product category statistics
 </br> </br>
![Personal product category statistics](https://user-images.githubusercontent.com/76628104/164085072-759d0ad6-bcc6-4bff-b8cf-1911d6bb5705.jpg)
 </br> </br>
 And finally the statistics that the department manager can view
  </br> </br>
![General department statistics](https://user-images.githubusercontent.com/76628104/164085359-ff1c6d3e-5313-41de-915e-82cd520f309d.jpg)
 </br> </br>
![Personalized department statistics](https://user-images.githubusercontent.com/76628104/164085371-91ededd4-8d6a-4ad5-a03f-559bb381ae1a.jpg)
 </br> </br>
6. All the managers have access to view, change, delete and create the things they manage(employees, product, departments)
 </br> </br>
![Product view](https://user-images.githubusercontent.com/76628104/164085592-bc8a7ac2-7c9d-46cc-9e7b-33e9d8b4f75f.jpg)
 </br> </br>
![Department view](https://user-images.githubusercontent.com/76628104/164085619-3bf6a586-24ba-4292-a816-88323456183f.jpg)
 </br> </br>
