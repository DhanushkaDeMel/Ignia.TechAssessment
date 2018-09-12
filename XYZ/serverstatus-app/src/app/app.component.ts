import { Component } from '@angular/core';
import { ServerHealthService } from './services/ServerHealthService';
import { ServerStatus } from './models/ServerStatus';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Server Health Check';

  serverStatus: ServerStatus[];
  error: any;
  loadingData: boolean;

  constructor(private serverHealthService: ServerHealthService) { }

  ngOnInit() {
    this.loadingData = true;
    this.getServerStatus();
  }
  
  reloadData(){
    this.serverStatus = null;
    this.loadingData = true;
    this.getServerStatus();
  }
    
  getServerStatus() {
    this.serverHealthService.get()
      .subscribe(
        (data: any) => {
          this.serverStatus = data.status as ServerStatus[]; 
          this.loadingData = false;
        }, // success path
        error => { 
          this.error = error;  
          this.loadingData = false;
         } // error path
      );
  }
}
