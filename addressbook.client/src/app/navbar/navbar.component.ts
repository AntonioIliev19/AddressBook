import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  @Output() searchTermChanged = new EventEmitter<string>();
  searchTerm: string = '';

  onSearchInput(event: any) {
    this.searchTermChanged.emit(this.searchTerm);
  }
}
