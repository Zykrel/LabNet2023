import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IShippers } from './../interfaces/shippers';
import { environment } from './../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  api: string = environment.api;
  endpoint: string = 'api/Shippers';

  constructor(private httpClient: HttpClient) { }

  public GetAll(): Observable<Array<IShippers>> {
    return this.httpClient.get<Array<IShippers>>(`${this.api}${this.endpoint}`);
  }
}
