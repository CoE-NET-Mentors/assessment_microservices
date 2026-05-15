import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class InventoryApi {
  getProduct(id: string): Observable<Product> {
    return throwError(() => new Error('Not implemented'));
  }
}