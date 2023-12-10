import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PeopleService {
  private apiUrl = 'https://localhost:7079/api/People'; // Update the URL to match your local API URL

  constructor(private http: HttpClient) { }

  fetchUsers(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
