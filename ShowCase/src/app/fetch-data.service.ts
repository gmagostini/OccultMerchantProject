import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Potion} from "./Items/Potion";
import {Spell} from "./Items/Spell";


@Injectable({
  providedIn: 'root'
})
export class FetchDataService {
  baseurl: string = "https://localhost:5001/";
  constructor(private http:HttpClient) { }

  private getAllRequest(url:string, filter: any){
    let headers: HttpHeaders = new  HttpHeaders();
    headers.set('Content-Type', 'application/json; charset=utf-8');
    return this.http.get<Array<any>>( this.baseurl +url,{headers:headers});
  }

  getAllPotion(){
   return  this.getAllRequest("potion/gettAll",{})
  }

  getAllSpell() {
    return  this.getAllRequest("spell/gettAll",{})
  }

  private postRequest(url:string, body:any){
    let headers: HttpHeaders = new  HttpHeaders();
    headers.set('Content-Type', 'application/json; charset=utf-8');
    return this.http.post<any>( this.baseurl + url,body,{headers:headers});
  }

  postPotion(body:Potion){
   return this.postRequest("potion",body)
  }
  postSpell(body: Spell) {
    return this.postRequest("spell",body);
  }

  private updateRequest(url:string,body:any){
    let headers: HttpHeaders = new  HttpHeaders();
    headers.set('Content-Type', 'application/json; charset=utf-8');
    return this.http.put(this.baseurl + url, body);
  }

  updatePotion(potion: Potion) {
    return this.updateRequest("potion", potion);
  }

  updateSpell(spells: Spell) {
    return this.updateRequest("spell", spells);
  }

  private deleteRequest(url:string,id:number){
    console.log("id:\t" + id);
    let str: string = this.baseurl + url +"/" + id.toString();
    console.log(str);
    return this.http.delete(this.baseurl + url +"/" + id.toString())
  }

  deletePotion(id:number){
    console.log("id:\t" + id);
    return this.deleteRequest("potion", id);
  }

  deleteSpell(id: number) {
    return this.deleteRequest("spell",id);

  }





}
