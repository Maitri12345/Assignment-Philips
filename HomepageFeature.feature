﻿Feature: HomepageFeature

A short summary of the feature

@tag1
Scenario: Check Todays weather
	Given Website must be open
	When I click on today button
	Then Today page will open

@tag2
Scenario: Check Click function of Times of India button
	Given Website must be provided
	When User able to click Times of India button
	Then page must be redirected to homepage

@tag2
Scenario: Check Search function of Search button
	Given Homepage should be open
	When User able to search city or postal code
	Then City name should be displayed



	

