select Reception.ID 
from 
	Reception,
	Pet	
where Reception.ID_Pet = Pet.ID
and Pet.Name = 'Санчо'