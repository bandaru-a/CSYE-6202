
ALTER TABLE User_Group_link
ADD CONSTRAINT fk_users
FOREIGN KEY (usr_id)
REFERENCES Users(usr_id);

ALTER TABLE User_Group_link
ADD CONSTRAINT fk_grps
FOREIGN KEY (grp_Id)
REFERENCES UserGroup(grp_Id);

ALTER TABLE Flight_Fare
ADD CONSTRAINT fk_flight
FOREIGN KEY (Flight_Id)
REFERENCES Flight_details(Flight_Id);

ALTER TABLE Ticket_details
ADD CONSTRAINT fk_TD_flight
FOREIGN KEY (Flight_Id)
REFERENCES Flight_details(Flight_Id);

ALTER TABLE Passengers
ADD CONSTRAINT fk_Ticket_Id
FOREIGN KEY (Ticket_Id)
REFERENCES Ticket_details(Ticket_Id) on delete cascade;

ALTER TABLE Crew
ADD CONSTRAINT fk_C_Flight_Id
FOREIGN KEY (Flight_Id)
REFERENCES Flight_details(Flight_Id);

ALTER TABLE Ticket_details
ADD CONSTRAINT fk_TD_BookedBy
FOREIGN KEY (Booked_by)
REFERENCES Users(Usr_Id);



