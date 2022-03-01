import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};


@Injectable({
  providedIn: 'root'
})

export class HomeService {

  private controller: string = '/api/home';

  constructor(private http: HttpClient) { }

  getContent(): Observable<any> {
    return this.http.get(this.controller, httpOptions );
  }
}