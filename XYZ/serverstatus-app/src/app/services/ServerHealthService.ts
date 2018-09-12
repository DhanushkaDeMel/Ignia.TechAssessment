
import { Observable } from 'rxjs';
import { ServerStatus } from '../models/ServerStatus';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './BaseService';
import { catchError } from 'rxjs/operators';
import { AppConfig } from '../config/AppConfig';
import { Injectable } from '@angular/core';

@Injectable()

export class ServerHealthService extends BaseService {

    private pathAPI = this.config.setting['PathAPI'];
  
    constructor(private http: HttpClient, private config: AppConfig) { super(); }

    get() {
        return this.http.get<ServerStatus>(this.pathAPI);
      }
}