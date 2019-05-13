import { Component } from '@angular/core';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  data: any;
  constructor(private datasvc: DataService) {

  }

  getData() {
    this.data = null;
    this.datasvc.getCustomer()
      .subscribe(res => {
        console.log(res);
        this.data = res;
      });
  }

}
