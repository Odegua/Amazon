Feature: CustomerCanViewProductDetail
	In order to know more about a product
	As a customer
	I want to be able to view the detail of the product


Scenario: Customer can view product price
	Given I navigate to the Amazon homepage
	And I search for wrist watch and I click on one of the search result displayed
    Then the product price is displayed
