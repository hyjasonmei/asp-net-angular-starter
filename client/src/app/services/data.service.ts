import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from './../../environments/environment';

@Injectable()
export class DataService {

  constructor(private http: HttpClient) { }

  getCustomer() {
    return this.http.get(`${environment.apiUrl}/api/HelloApi`);
  }

  run() {
    console.log('run');
    return { 'aaa': 'bbb' };
  }
}
