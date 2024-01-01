import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { Result } from '../user.model'; // Import the interfaces
import { HttpClient } from '@angular/common/http';
import { PeopleService } from '../people.service';

@Component({
  selector: 'app-people-list',
  templateUrl: './people-list.component.html',
  styleUrls: ['./people-list.component.css']
})
export class PeopleListComponent implements OnInit {
  @Input() searchTerm: string = '';
  @Output() userSelected = new EventEmitter<Result | null>();
  @Output() searchTermChanged = new EventEmitter<string>();

  users: Result[] = [];
  filteredUsers: Result[] = [];
  selectedUser: Result | null = null;

  constructor(private http: HttpClient, private peopleservice: PeopleService) { }

  ngOnInit() {
    this.peopleservice.fetchUsers().subscribe(users => {
      this.users = users;
      this.filterUsers();
      console.log("Init working")
    });
  }

  filterUsers() {
    if (!this.searchTerm) {
      this.filteredUsers = this.users; // If no search term, show all users
    } else {
      // Convert search term to lowercase for case-insensitive search
      const searchTermLower = this.searchTerm.toLowerCase();

      // Filter users based on the search term
      this.filteredUsers = this.users.filter(user => {
        // Split the email address by "@" to get the name part
        const emailParts = user.email.split('@');
        if (emailParts.length === 2) {
          // Split the name part by "." to get first and last names
          const nameParts = emailParts[0].split('.');
          if (nameParts.length === 2) {
            const firstName = nameParts[0].toLowerCase();
            const lastName = nameParts[1].toLowerCase();

            // Check if the first or last name matches the search term
            return (
              firstName.includes(searchTermLower) || lastName.includes(searchTermLower)
            );
          }
        }
        return false;
      });

      console.log('Filtered Users:', this.filteredUsers);
    }
  }

  handleSearchTermChanged(term: string) {  // Use it in the people-list.component.html to trigger it in the navbar
    this.searchTerm = term;
    this.filterUsers(); // Trigger filtering
  }


  showUserDetails(user: any) {
    this.selectedUser = user;
    this.userSelected.emit(user);
  }

  closeUserDetails() {
    this.selectedUser = null;
    this.userSelected.emit(null);
  }

}
