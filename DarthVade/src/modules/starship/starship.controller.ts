import { Controller, Get, Post, Body, Put, Param, Delete } from '@nestjs/common';
import { ServicePull } from 'src/Services/Service.pull';
import { Starship } from './starship.entity';
import { StarshipService } from './starship.service';

@Controller('starship')
export class StarshipController {
  constructor(private readonly entityService: StarshipService,
     private readonly servicePull: ServicePull, 
    ) {}

  @Get('pull')
  pull() {  
    return  this.servicePull.Pull<Starship>('starships', [],[],                                   
                                      this.entityService, 1); 
  }

  @Get('pull/relations')
  pullRelations() {  
    return  this.servicePull.Pull<Starship>('starships', 
                                      ['people','films'],
                                      ['pilots','films'],
                                      this.entityService, 1); 
  }

  /*
  @Post()
  create(@Body() entity: Starship) {
    return this.entityService.create(entity);
  }

  @Get()
  findAll() {
    return this.entityService.findAll();
  }

  @Get(':id')
  findOne(@Param('id') id: string) {
    return this.entityService.findOne(+id);
  }

  @Put(':id')
  update(@Param('id') id: string, @Body() entity: Starship ) {
    return this.entityService.update(+id, entity);
  }

  @Delete(':id')
  remove(@Param('id') id: string) {
    return this.entityService.remove(+id);
  }
  */
}
