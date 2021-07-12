# Source Control VS
Initial source control with Visual Studio for the first week of Summer Quarter, 2021.

*Overview for Advanced .Net Programming.*

    Practice Teamwork Development:
    
        * Issues: Title and Description
        * Assignees
        * Labels
        
*GitHub Flow Resource:* https://guides.github.com/introduction/flow/

    Branching Process:
    
        1.) Create a new branch
            - Do not work in the Master/Main/Default.
            
        2.) Add commits
            - A single branch may take a single or many commits to keep track of your work.
            
        3.) Open a pull request
            - Code review can take place to verify quality code before merging into your product.
            
        4.) Merge into Master/Main/Default 
            - After pull request is reviewed and accepted it can be merged into the base branch.
            
*Databases and Source Control*

    Working with data:
    
       - Scripts can be stored in source control.
       - Keep in a separate database project.
       - Never put sensitive information in source control.
            - Connection strings
            - Other credentials
       - What server should we use for development?
            - Our whole team needs a consistend development experience
       - What server should we use for production?
       - Let the database take care of:
            * Sorting - ORDER BY
            * Filtering - WHERE
            * Joins
            * Subqueries
            * Aggregates
       - Only send the application the data you need.
### Agile Development Brief-Introduction

In software development,
agile practices involve discovering requirements and developing solutions
through the collaborative effort of self-organizing and cross-functional teams and their customer/end user. *@Wikipedia*


    Continuous Process:

        1.) Requirements

        2.) Plan

        3.) Design

        4.) Develop

        5.) Release

        6.) Track & Monitor
