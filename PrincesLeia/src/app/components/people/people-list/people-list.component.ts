import { Component, OnInit } from '@angular/core';
import { People } from 'src/app/models/people.models';
import { PeopleService } from 'src/app/services/people.service';

@Component({
  selector: 'app-People-list',
  templateUrl: './people-list.component.html',
  styleUrls: ['./people-list.component.css']
})
export class PeopleListComponent implements OnInit {
  entyties?: People[];
  entity?: People;
  currentIndex = -1;
  name = '';

  constructor(private _Service: PeopleService) { }

  ngOnInit(): void {
    this.retrieveEntities(); 
  }



  retrieveEntities(): void { 
    this._Service.getAll()
      .subscribe(
        data => {
          this.entyties = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  refreshList(): void {
    this.retrieveEntities();
    this.entity = undefined;
    this.currentIndex = -1;
  }

  setActiveEntity(entity: People, index: number): void {
    this.entity = entity;
    this.currentIndex = index;
  }

  removeAll(): void {
    this._Service.deleteAll()
      .subscribe(
        response => {
          console.log(response);
          this.refreshList();
        },
        error => {
          console.log(error);
        });
  }

  searchName(): void {
    this.entity = undefined;
    this.currentIndex = -1;

    this._Service.findByName(this.name)
      .subscribe(
        data => {
          this.entyties = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

}
