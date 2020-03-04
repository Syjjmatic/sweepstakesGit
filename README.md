# sweepstakesGit

USER STORY (5 points):
As a developer, I want to document (text file, canvas comment, etc.) where I am using dependency injection and what benefits it 
adds to the structure of my application.

Answer:
I am using dependency injection in the MartketingForm class. To create a new MarketingFirm, any class that utlizes the
ISweepstakesManager interface can be sent into the MarketingFirm class and will be used to create it. This provides a benefit to
the program in the event that the Marketing Firm user wants to create a new class that manages sweepstakes. As long as the new
class inherits the ISweepstakesManager interface, it is interchangeable.