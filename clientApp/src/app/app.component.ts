import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  response : any;
  constructor(private http: HttpClient)
  {
    let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    this.http.get('http://localhost:5000/WeatherForecast', { headers: headers }).subscribe(d => this.response = d);
  }

}
