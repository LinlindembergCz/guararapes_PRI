import { Injectable , BadRequestException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Vehicle } from './vehicle.entity';
import { VehicleRepository } from './vehicle.repository';

@Injectable()
export class VehicleService {

  constructor(
    @InjectRepository(VehicleRepository)
    private readonly _entityRepository: VehicleRepository,
    )
    {      
    }

    async ExecRelationCommand(tableName: string , idsRelation: string  )
    {
      //console.log( tableName + "   "+ idsRelation ); 
      await this._entityRepository.
      createQueryBuilder().
      insert().
      into(tableName).
      //values([{filmsId: idMaster , speciesid: idDetail}]).
      values([ JSON.parse( idsRelation ) ]).
      execute();
    }
  
    
  async create(entity: Vehicle):Promise<Vehicle>  {
    const saveEntity = await this._entityRepository.save(entity);
        return saveEntity;
  }

  async findAll() : Promise<Vehicle[]> {

   const entities: Vehicle[] = await this._entityRepository.find()
        return entities
  }

  async findOne(id: number): Promise<Vehicle> {
      if(!id)
      {
          throw new BadRequestException('Id é requerido!');
      }
      const entity: Vehicle = await this._entityRepository.
      findOne(id);
      if (!entity)
      {
          throw new BadRequestException('Vehicle nao existe!');
      }
      return entity;
  }

  async  findOneIdByUrl(_url: string): Promise<bigint>
  {
    if(!_url)
    {
        throw new BadRequestException('url é requerido!');
    }
    const entity: Vehicle = await this._entityRepository.findOne({where: {url:_url }});
    if (!entity)
    {
        throw new BadRequestException('Id nao existe!');
    }
    return entity.id;
  }

  async update(id: number, entity: Vehicle):Promise<void> {
    await this._entityRepository.update(id, entity);
  }

  async remove(id: number) {
    const Exists = await this._entityRepository.
        findOne(id );

        if(!Exists)
        {
            throw new BadRequestException('Vehicle nao existe!');  
        }
        await this._entityRepository.delete(id);
  }
  

 
}
